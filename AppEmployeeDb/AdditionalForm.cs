﻿using AppEmployeeDb.DbContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEmployeeDb.Repository;
using AppEmployeeDb.Models;

namespace AppEmployeeDb
{
    public partial class AdditionalForm : Form
    {
        private readonly IEmloyeeRepository _repository;
        private int _id = 0;

        public AdditionalForm(IEmloyeeRepository repository)
        {
            _repository = repository;

            InitializeComponent();
        }

        public AdditionalForm(IEmloyeeRepository repository, Employee employee) : this(repository)
        {
            SetFields(employee);
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                Name = Name.Text,
                Birthday = Birthday.Value,
                JobTitle = JobTitle.Text,
                Subdivision = Subdivision.Text
            };

            //Если запись передана на изменение, то _id должен быть заполнен в методе SetFields
            if (_id > 0)
                employee.Id = _id;

            await _repository.CreateUpdateEmployee(employee);

            ClearFields();
        }

        private void SetFields(Employee employee)
        {
            _id = employee.Id;
            Name.Text = string.Empty;
            Birthday.Value = DateTime.Now;
            JobTitle.Text = string.Empty;
            Subdivision.Text = string.Empty;
        }

        private void ClearFields()
        {
            Name.Text = string.Empty;
            Birthday.Value = DateTime.Now;
            JobTitle.Text = string.Empty;
            Subdivision.Text = string.Empty;
        }
    }
}