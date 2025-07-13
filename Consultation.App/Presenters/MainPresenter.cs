using Consultation.App.ConsultationManagement;
using Consultation.App.Dashboard;
using Consultation.App.Views;
using Consultation.App.Views.IViews;
using System;
using System.Collections.Generic;
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
            UserManagement
        }

        private ChildViews _currentView;

        private readonly Dictionary<ChildViews, IChildView> _childViews = new();

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;

            _mainView.DashboardEvent += DashboardEvent;
            _mainView.BulletinEvent += BulletinEvent;
            _mainView.ConsultationEvent += ConsultationEvent;
            _mainView.SFManagementEvent += SFManagementEvent;

            LoadChildView(ChildViews.Dashboard);
            _mainView.Header("Dashboard");
            _currentView = ChildViews.Dashboard;

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

        private void LoadChildView(ChildViews viewType)
        {
            if (!_childViews.TryGetValue(viewType, out var view))
            {
                view = CreateViewByType(viewType);
                //if (view == null)
                    //throw new Exception($"CreateViewByType({viewType}) returned null!");
                _childViews[viewType] = view;
            }

            if (_mainView == null)
                throw new Exception("_mainView is null!");

            if (_mainView.MainPanel == null)
                throw new Exception("_mainView.MainPanel is null!");

            if (view.AsUserControl == null)
                throw new Exception($"view.AsUserControl is null for {viewType}!");

            _mainView.MainPanel.Controls.Clear();
            view.AsUserControl.Dock = DockStyle.Fill;
            _mainView.MainPanel.Controls.Add(view.AsUserControl);
            view.AsUserControl.BringToFront();
        }

        private IChildView CreateViewByType(ChildViews viewType)
        {
            return viewType switch
            {
                ChildViews.Dashboard => new MainDashboardUserControl(),
                ChildViews.Consultation => new ConsultationView() as IConsultationView,
                ChildViews.Bulletin => new BulletinView() as IBulletinView,
                ChildViews.UserManagement => new UserManagementView() as IUserManagementView,
                _   => throw new NotImplementedException()
            };
        }

        private void SetActiveButton(Button? button)
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
