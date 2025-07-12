using Consultation.App.Views.IViews;
using Consultation.App.Views.TestViews;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Consultation.App.Views;
using Consultation.App.ConsultationManagement;

namespace Consultation.App.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;

        // Enum to identify each child UserControl
        private enum ChildViews
        {
            Dashboard,
            Bulletin,
            Consultation,
            UserManagement,
            Reports,
            Settings
        }

        private ChildViews _currentView;

        private readonly Dictionary<ChildViews, UserControl> _childViews = new();

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;

            _mainView.DashboardEvent += DashboardEvent;
            _mainView.BulletinEvent += BulletinEvent;
            _mainView.ConsultationEvent += ConsultationEvent;
            _mainView.SFManagementEvent += SFManagementEvent;
            _mainView.ReportsEvent += ReportsEvent;
            _mainView.PreferenceEvent += PreferenceEvent;

            LoadChildView(ChildViews.Dashboard);
            _mainView.Header("Dashboard");
            _currentView = ChildViews.Dashboard;
        }

        // Event handlers
        private void DashboardEvent(object? sender, EventArgs e)
        {
            if (_currentView != ChildViews.Dashboard)
            {
                LoadChildView(ChildViews.Dashboard);
                _mainView.Header("Dashboard");
                _currentView = ChildViews.Dashboard;
            }
        }

        private void BulletinEvent(object? sender, EventArgs e)
        {
            if (_currentView != ChildViews.Bulletin)
            {
                LoadChildView(ChildViews.Bulletin);
                _mainView.Header("Bulletin");
                _currentView = ChildViews.Bulletin;
            }
        }

        private void ConsultationEvent(object? sender, EventArgs e)
        {
            if (_currentView != ChildViews.Consultation)
            {
                LoadChildView(ChildViews.Consultation);
                _mainView.Header("Consultation");
                _currentView = ChildViews.Consultation;
            }
        }

        private void SFManagementEvent(object? sender, EventArgs e)
        {
            if (_currentView != ChildViews.UserManagement)
            {
                LoadChildView(ChildViews.UserManagement);
                _mainView.Header("User Management");
                _currentView = ChildViews.UserManagement;
            }
        }

        private void ReportsEvent(object? sender, EventArgs e)
        {
            if (_currentView != ChildViews.Reports)
            {
                LoadChildView(ChildViews.Reports);
                _mainView.Header("Reports");
                _currentView = ChildViews.Reports;
            }
        }

        private void PreferenceEvent(object? sender, EventArgs e)
        {
            _mainView.SetMessage("Setting Event Triggered");
        }

        private void LoadChildView(ChildViews viewType)
        {
            if (!_childViews.TryGetValue(viewType, out var view) || view.IsDisposed)
            {
                view = CreateViewByType(viewType);
                _childViews[viewType] = view;
            }

            // Clear the container and add the new UserControl
            _mainView.MainPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            _mainView.MainPanel.Controls.Add(view);
            view.BringToFront();
        }

        //private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Application.Exit();
        //}

        private UserControl CreateViewByType(ChildViews viewType)
        {
            return viewType switch
            {
                ChildViews.Dashboard => new DashboardView(), // Must be UserControl now
                ChildViews.Consultation => new ConsultationView(),
                ChildViews.Bulletin => new BulletinView(),
                ChildViews.UserManagement => new UserManagementView(),
                _ => new UserControl() { Name = "NotImplementedView" }
            };
        }
    }
}
