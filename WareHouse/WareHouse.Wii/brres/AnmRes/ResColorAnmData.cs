﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.io;

namespace WareHouse.Wii.brres.AnmRes
{
    public class ResColorAnmData
    {
        public ResColorAnmData(MemoryFile file, bool isOneFrame, ushort frameCount)
        {
            if (isOneFrame)
            {
                mColorFrame = file.ReadUInt32();
            }
            else
            {
                file.Seek(file.Position() + file.ReadInt32());
                for (ushort i = 0; i < frameCount; i++)
                {
                    mColorFrames.Add(file.ReadUInt32());
                }
            }
        }

        uint mColorFrame;
        List<uint> mColorFrames = new();
    }
}
