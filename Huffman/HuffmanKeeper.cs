﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    public class HuffmanKeeper
    {
        private List<bool> encodedText = new List<bool>();
        private List<String> decodedText = new List<String>();

        public List<bool> getEncodedText()
        {
            return encodedText;
        }

        public void setEncodedText(List<bool> values)
        {
            encodedText = values;
        }

        public List<String> getDecodedText()
        {
            return decodedText;
        }

        public void addDecodedLine(String line)
        {
            decodedText.Add(line);
        }

        public void clearKeeper()
        {
            encodedText.Clear();
            decodedText.Clear();
        }
    }
}