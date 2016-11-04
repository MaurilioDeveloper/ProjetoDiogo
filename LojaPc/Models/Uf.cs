using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaPc.Models
{
    public class Uf
    {
        public const string AC = "Acre";
        public const string AL = "Alagoas";
        public const string AP = "Amapá";
        public const string AM = "Amazonas";
        public const string BA = "Bahia";
        public const string CE = "Ceará";
        public const string DF = "Distrito Federal";
        public const string ES = "Espírito Santo";
        public const string GO = "Goiás";
        public const string MA = "Maranhão";
        public const string MT = "Mato Grosso";
        public const string MS = "Mato Grosso do Sul";
        public const string MG = "Minas Gerais";
        public const string PA = "Pará";
        public const string PB = "Paraíba";
        public const string PR = "Paraná";
        public const string PE = "Pernambuco";
        public const string PI = "Piauí";
        public const string RJ = "Rio de Janeiro";
        public const string RN = "Rio Grande do Norte";
        public const string RS = "Rio Grande do Sul";
        public const string RO = "Rondônia";
        public const string RR = "Roraima";
        public const string SC = "Santa Catarina";
        public const string SP = "São Paulo";
        public const string SE = "Sergipe";
        public const string TO = "Tocantins";

        public static List<string> ToList()
        {
            List<string> list = new List<string>();
            list.Add(AC);
            list.Add(AL);
            list.Add(AP);
            list.Add(AM);
            list.Add(BA);
            list.Add(CE);
            list.Add(DF);
            list.Add(ES);
            list.Add(GO);
            list.Add(MA);
            list.Add(MT);
            list.Add(MS);
            list.Add(MG);
            list.Add(PA);
            list.Add(PB);
            list.Add(PR);
            list.Add(PE);
            list.Add(PI);
            list.Add(RJ);
            list.Add(RN);
            list.Add(RS);
            list.Add(RO);
            list.Add(RR);
            list.Add(SC);
            list.Add(SP);
            list.Add(SE);
            list.Add(TO);
            return list;
        }
    }
}