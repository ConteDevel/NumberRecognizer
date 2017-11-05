using NumberRecognizer.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NumberRecognizer
{
    public class NetTraining
    {
        private static readonly string[] FileExtensions = {
            ".png",
            ".jpg",
            ".gif",
            ".tiff"
        };

        private static int SuitsCount = 9;

        private string _srcPath;
        private string _dataPath;
        private int _tilesCount;

        public NetTraining(string srcPath, string dataPath, int tilesCount)
        {
            _srcPath = srcPath;
            _dataPath = dataPath;
            _tilesCount = tilesCount;
        }

        public bool Process()
        {
            var files = GetFiles();

            if (PrepareData(files, out List<DataNode> data) && SaveData(data))
            {

            }

            return false;
        }

        private string[] GetFiles()
        {
            if (Directory.Exists(_srcPath))
            {
                try
                {
                    return Directory.GetFiles(_srcPath, "*.*")
                        .Where(f => FileExtensions.Contains(Path.GetExtension(f).ToLower()))
                        .ToArray();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace);
                }
            }

            return new string[0];
        }

        private bool PrepareData(string[] files, out List<DataNode> data)
        {
            data = new List<DataNode>();

            if (files.Length != 0)
            {
                try
                {
                    foreach (var file in files)
                    {
                        using (var bmp = Image.FromFile(file) as Bitmap)
                        {
                            bmp.MakeGrayscale();
                            int w = bmp.Width / _tilesCount;
                            int h = bmp.Height / SuitsCount;
                            int fullWidth = w * _tilesCount;
                            var rect = new Rectangle(0, 0, w, h);

                            for (int i = 0; i < SuitsCount; ++i)
                            {
                                for (int offset = 0; offset < fullWidth; offset += w)
                                {
                                    rect.Offset(offset, 0);
                                    var node = new DataNode()
                                    {
                                        digit = i + 1,
                                        matrix = GetMatrix(bmp, rect, w, h)
                                    };
                                    data.Add(node);
                                }

                                rect.Offset(0, h);
                            }
                        }
                    }

                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace);
                }
            }

            return false;
        }

        private bool SaveData(List<DataNode> nodes)
        {
            if (nodes.Any())
            {
                try
                {
                    using (var sw = new StreamWriter(_dataPath))
                    {
                        int inputCount = nodes[0].matrix.Length;
                        var title = string.Format("{0} {1} {2}", nodes.Count, inputCount, 1);
                        sw.WriteLine(title);

                        foreach (var node in nodes)
                        {                            
                            foreach (float v in node.matrix)
                            {
                                sw.Write(v + " ");
                            }

                            sw.Write("{1}{0}{1}", node.digit, Environment.NewLine);
                        }

                        return true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace);
                }
            }

            return false;
        }

        private float[,] GetMatrix(Bitmap bmp, Rectangle rect, int width, int height)
        {
            using (var tile = bmp.GetTile(rect, width, height))
            {
                var mtx = new float[tile.Width, tile.Height];

                for (int i = 0; i < tile.Width; ++i)
                {
                    for (int j = 0; j < tile.Height; ++j)
                    {
                        var c = tile.GetPixel(i, j);
                        mtx[i, j] = 1f - (c.R + c.G + c.B) / 3f / 255;
                    }
                }

                return mtx;
            }
        }

        private class DataNode
        {
            public float[,] matrix;
            public int digit;
        }
    }
}
