using Consultation.App.ConsultationManagement;
using Consultation.App.Views;
using Consultation.App.Views.IViews;
using Consultation.App.Views.TestViews;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Consultation.App.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;

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

            // Highlight default button manually
            if (_mainView is MainView view)
            {
                SetActiveButton(view.Controls.Find("buttonDashboard", true)[0] as Button);
            }
        }

        private void DashboardEvent(object? sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            if (_currentView != ChildViews.Dashboard)
            {
                LoadChildView(ChildViews.Dashboard);
                _mainView.Header("Dashboard");
                _currentView = ChildViews.Dashboard;
            }
        }

        private void BulletinEvent(object? sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            if (_currentView != ChildViews.Bulletin)
            {
                LoadChildView(ChildViews.Bulletin);
                _mainView.Header("Bulletin");
                _currentView = ChildViews.Bulletin;
            }
        }

        private void ConsultationEvent(object? sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            if (_currentView != ChildViews.Consultation)
            {
                LoadChildView(ChildViews.Consultation);
                _mainView.Header("Consultation");
                _currentView = ChildViews.Consultation;
            }
        }

        private void SFManagementEvent(object? sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            if (_currentView != ChildViews.UserManagement)
            {
                LoadChildView(ChildViews.UserManagement);
                _mainView.Header("User Management");
                _currentView = ChildViews.UserManagement;
            }
        }

        private void ReportsEvent(object? sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            if (_currentView != ChildViews.Reports)
            {
                LoadChildView(ChildViews.Reports);
                _mainView.Header("Reports");
                _currentView = ChildViews.Reports;
            }
        }

        private void PreferenceEvent(object? sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            _mainView.SetMessage("Settings clicked");
        }

        private void LoadChildView(ChildViews viewType)
        {
            if (!_childViews.TryGetValue(viewType, out var view) || view.IsDisposed)
            {
                view = CreateViewByType(viewType);
                _childViews[viewType] = view;
            }

            _mainView.MainPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            _mainView.MainPanel.Controls.Add(view);
            view.BringToFront();
        }

        private UserControl CreateViewByType(ChildViews viewType)
        {
            return viewType switch
            {
                ChildViews.Dashboard => new DashboardView(),
                ChildViews.Consultation => new ConsultationView(),
                ChildViews.Bulletin => new BulletinView(),
                ChildViews.UserManagement => new UserManagementView(),
                _ => new UserControl() { Name = "NotImplementedView" }
            };
        }

        private void SetActiveButton(Button button)
        {
            if (button == null) return;

            if (_mainView.CurrentActiveButton != null)
            {
                _mainView.ResetButton(_mainView.CurrentActiveButton);
            }

            _mainView.HighlightButton(button);
            _mainView.CurrentActiveButton = button;
        }
    }
}
