using GreatMaps.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;

namespace GreatMaps.ViewModel
{    class GreatMapViewModel
    {
        public GreatMapModel GreatMapModel { get; set; }
        public GreatMapViewModel()
        {
            InitializeFields();
            System.Console.WriteLine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Resource\Data.gmdb");
        }

        private void InitializeFields()
        {
            GreatMapModel = new GreatMapModel();
        }

        private void Method()
        {

        }
    }
}

