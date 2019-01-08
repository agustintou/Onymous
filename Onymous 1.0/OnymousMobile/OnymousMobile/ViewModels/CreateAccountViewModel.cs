﻿using GalaSoft.MvvmLight.Command;
using OnymousMobile.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnymousMobile.ViewModels
{
    public class CreateAccountViewModel : BaseViewModel
    {
        #region Attributes
        private Person _person { get; set; }
        public Person Person
        {
            get
            {
                return this._person;
            }
            set
            {
                if(value != _person)
                {
                    _person = value;
                    OnPropertyChanged();
                }
            }
        }

        private User _user { get; set; }
        public User User
        {
            get
            {
                return this._user;
            }
            set
            {
                if (value != _user)
                {
                    _user = value;
                    OnPropertyChanged();
                }
            }
        }

        public string _confirmPassword { get; set; }
        public string ConfirmPassword
        {
            get
            {
                return this._confirmPassword;
            }
            set
            {
                if (value != _confirmPassword)
                {
                    _confirmPassword = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandRegister { get { return new RelayCommand(RegisterC); } }
        #endregion

        #region Builders
        public CreateAccountViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        void RegisterC()
        {

        }
        #endregion

        #region Methods
        void InitialData()
        {
            Person = new Person();
            User = new User();
            ConfirmPassword = string.Empty;
        }
        #endregion
    }
}
