using System;

namespace Biblioteka
{
    [Serializable]
    public class ModelInfo  // Info o pliku 
    {
        public byte[] Data { get; set; }
        public string Extension { get; set; }
        public string FileName { get; set; }
    }
}