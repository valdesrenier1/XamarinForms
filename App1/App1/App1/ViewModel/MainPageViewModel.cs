using System;
using System.Collections.Generic;
using System.Text;

namespace App1.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            Prompt = "Full Name:";
            Name = "Renier";
        }

        public string Prompt { get; set; }
        public string Name { get; set; }
        
    }
}
