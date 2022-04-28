using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie6.Base;

namespace Zadanie6
{
    public class Person : ExtendedNotifyPropertyChanged
    {
        private string? _name;
        private string? _surname;
        private string? _email;
        private double? _deposit;
        private RegionEnum? _region;
        private double _accessLevel;
        

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string? Surname
        {
            get => _surname;
            set => SetProperty(ref _surname, value);
        }


        public string? Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public double? Deposit
        {
            get => _deposit;
            set => SetProperty(ref _deposit, value);
        }

        public RegionEnum? Region
        {
            get => _region;
            set => SetProperty(ref _region, value);
        }

        public double AccessLevel
        {
            get => _accessLevel;
            set => SetProperty(ref _accessLevel, value);
        }
    }
}
