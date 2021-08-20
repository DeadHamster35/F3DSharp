using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3DSharp
{
    class F3DEX095_Parameters
    {


        public static UInt32 G_IM_SIZ_4b = 0;
        public static UInt32 G_IM_SIZ_8b = 1;
        public static UInt32 G_IM_SIZ_16b = 2;
        public static UInt32 G_IM_SIZ_32b = 3;
        public static UInt32 G_IM_SIZ_DD = 5;

        public static UInt32 G_IM_SIZ_4b_BYTES = 0;
        public static UInt32 G_IM_SIZ_4b_TILE_BYTES = G_IM_SIZ_4b_BYTES;
        public static UInt32 G_IM_SIZ_4b_LINE_BYTES = G_IM_SIZ_4b_BYTES;

        public static UInt32 G_IM_SIZ_8b_BYTES = 1;
        public static UInt32 G_IM_SIZ_8b_TILE_BYTES = G_IM_SIZ_8b_BYTES;
        public static UInt32 G_IM_SIZ_8b_LINE_BYTES = G_IM_SIZ_8b_BYTES;

        public static UInt32 G_IM_SIZ_16b_BYTES = 2;
        public static UInt32 G_IM_SIZ_16b_TILE_BYTES = G_IM_SIZ_16b_BYTES;
        public static UInt32 G_IM_SIZ_16b_LINE_BYTES = G_IM_SIZ_16b_BYTES;

        public static UInt32 G_IM_SIZ_32b_BYTES = 4;
        public static UInt32 G_IM_SIZ_32b_TILE_BYTES = 2;
        public static UInt32 G_IM_SIZ_32b_LINE_BYTES = 2;

        public static UInt32 G_IM_SIZ_4b_LOAD_BLOCK = G_IM_SIZ_16b;
        public static UInt32 G_IM_SIZ_8b_LOAD_BLOCK = G_IM_SIZ_16b;
        public static UInt32 G_IM_SIZ_16b_LOAD_BLOCK = G_IM_SIZ_16b;
        public static UInt32 G_IM_SIZ_32b_LOAD_BLOCK = G_IM_SIZ_32b;

        public static UInt32 G_IM_SIZ_4b_SHIFT = 2;
        public static UInt32 G_IM_SIZ_8b_SHIFT = 1;
        public static UInt32 G_IM_SIZ_16b_SHIFT = 0;
        public static UInt32 G_IM_SIZ_32b_SHIFT = 0;

        public static UInt32 G_IM_SIZ_4b_INCR = 3;
        public static UInt32 G_IM_SIZ_8b_INCR = 1;
        public static UInt32 G_IM_SIZ_16b_INCR = 0;
        public static UInt32 G_IM_SIZ_32b_INCR = 0;

        public static UInt32[] G_IM_ArrayLineBytes = { G_IM_SIZ_4b_LINE_BYTES, G_IM_SIZ_8b_LINE_BYTES, G_IM_SIZ_16b_LINE_BYTES, G_IM_SIZ_32b_LINE_BYTES };

        public static UInt32 G_TEXTURE_IMAGE_FRAC   = 2;
        public static UInt32 G_TEXTURE_SCALE_FRAC   = 16;
        public static UInt32 G_SCALE_FRAC           = 8;
        public static UInt32 G_ROTATE_FRAC          = 16;

    }
}
