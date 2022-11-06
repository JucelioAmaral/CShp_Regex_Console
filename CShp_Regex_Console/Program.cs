using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace CShp_Regex_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsMainPoema clsPoema = new clsMainPoema();
            clsPoema.RegexPoema();


            clsMainExemplosRegexCPF clsRegexCPF = new clsMainExemplosRegexCPF();
            clsRegexCPF.RegexCPF();
        }
    }
}
