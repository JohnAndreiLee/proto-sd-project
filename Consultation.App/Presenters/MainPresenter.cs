using Consultation.App.Views.IViews;
using Consultation.App.Views.TestViews;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Consultation.App.Views;

namespace Consultation.App.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;

        // Enum to identify each child form
        private enum ChildForms
        {
            Dashboard,
            Bulletin,
            Consultation,
            UserManagement,
            Reports,
            Preference
        }

        private ChildForms _currentForm;
        private Form _activeForm;

        private readonly Dictionary<ChildForms, Form> _childForms = new();

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;

            _mainView.DashboardEvent += DashboardEvent;
            _mainView.BulletinEvent += BulletinEvent;
            _mainView.ConsultationEvent += ConsultationEvent;
            _mainView.SFManagementEvent += SFManagementEvent;
            _mainView.ReportsEvent += ReportsEvent;
            _mainView.PreferenceEvent += PreferenceEvent;

            LoadChildForm(ChildForms.Dashboard);
            _currentForm = ChildForms.Dashboard;
        }

        // Event handlers
        private void DashboardEvent(object? sender, EventArgs e)
        {
            if (_currentForm != ChildForms.Dashboard)
            {
                LoadChildForm(ChildForms.Dashboard);
                _mainView.Header("Dashboard");
                _currentForm = ChildForms.Dashboard;
            }
        }

        private void BulletinEvent(object? sender, EventArgs e)
        {
            if (_currentForm != ChildForms.Bulletin)
            {
                LoadChildForm(ChildForms.Bulletin);
                _mainView.Header("Bulletin Management");
                _currentForm = ChildForms.Bulletin;
            }
        }

        private void ConsultationEvent(object? sender, EventArgs e)
        {
            _mainView.SetMessage("Consultation Event Triggered");
        }

        private void SFManagementEvent(object? sender, EventArgs e)
        {
            if (_currentForm != ChildForms.UserManagement)
            {
                LoadChildForm(ChildForms.UserManagement);
                _mainView.Header("User Management");
                _currentForm = ChildForms.UserManagement;
            }
        }

        private void ReportsEvent(object? sender, EventArgs e)
        {
            if (_currentForm != ChildForms.Reports)
            {
                LoadChildForm(ChildForms.Reports);
                _mainView.Header("Reports");
                _currentForm = ChildForms.Reports;
            }
        }

        private void PreferenceEvent(object? sender, EventArgs e)
        {
            _mainView.SetMessage("Preference Event Triggered");
        }

        private void LoadChildForm(ChildForms formType)
        {
            if (_activeForm != null && !_activeForm.IsDisposed)
            {
                _activeForm.Hide();
            }

            if (!_childForms.TryGetValue(formType, out var form) || form.IsDisposed)
            {
                form = CreateFormByType(formType);
                _childForms[formType] = form;
            }

            // Must be done before showing
            //form.FormBorderStyle = FormBorderStyle.None;
            form.MdiParent = (Form)_mainView;
            form.Dock = DockStyle.Fill;
            form.ShowInTaskbar = false;

            _activeForm = form;
            form.Show();
            form.BringToFront();
        }



        private Form CreateFormByType(ChildForms formType)
        {
            return formType switch
            {
                ChildForms.Dashboard => new DashboardView(),
                ChildForms.Bulletin => new BulletinView(),
                ChildForms.Reports => new ReportsView(),
                ChildForms.UserManagement => new UserManagementView(),
                _ => new Form() { Text = "Not Implemented" }
            };
        }
    }
}
