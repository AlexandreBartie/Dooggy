﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dooggy
{
    public static class xInt
    {

        public static int IIf(bool prmCondicao, int prmValorPOS, int prmValorNEG)
        {

            if (prmCondicao)
                return (prmValorPOS);

            return (prmValorNEG);

        }

        public static bool IsPositivo(int prmValor)
        {

            if (prmValor >= 0)
                return (true);

            return (false);

        }

        public static int GetInverter(bool prmCondicao, int prmValor)
        {

            if (prmCondicao)
                return (prmValor);

            return (-prmValor);

        }

        public static int GetPositivo(int prmValor) => (System.Math.Abs(prmValor));
    }
}