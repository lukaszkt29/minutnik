using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using System.Collections.Generic;
namespace minutnik;

public partial class MainWindow : Window
{

    private readonly List<string> _history = new();
    

    private readonly DispatcherTimer _timer;
    private int _remainingSeconds;
    private int _completedCycles;
    private bool _isRunning;
    private bool _isBreakPhase;

    public MainWindow()
    {
        InitializeComponent();

        _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
        _timer.Tick += OnTimerTick;

        _remainingSeconds = GetWorkSeconds();
        UpdateDisplay();
    }

    // --- Helpers ---------------------------------------------------------

    private int GetWorkSeconds() =>
        (int)(WorkMinutesInput.Value ?? 25) * 60;

    private int GetBreakSeconds() =>
        (int)(BreakMinutesInput.Value ?? 5) * 60;

    private void UpdateDisplay()
    {
        int minutes = _remainingSeconds / 60;
        int seconds = _remainingSeconds % 60;
        TimerDisplay.Text = $"{minutes:D2}:{seconds:D2}";
        CycleCounter.Text = $"Ukończone cykle: {_completedCycles}";
        PhaseLabel.Text = _isBreakPhase ? "Przerwa" : "Praca";
    }

    private void SetInputsEnabled(bool enabled)
    {
        WorkMinutesInput.IsEnabled = enabled;
        BreakMinutesInput.IsEnabled = enabled;
    }

    // --- Timer logic ----------------------------------------------------

    private void OnTimerTick(object? sender, EventArgs e)
    {
        _remainingSeconds--;

        if (_remainingSeconds <= 0)
        {
            if (_isBreakPhase)
            {
                // Break finished → go back to work phase (stopped)
                _isBreakPhase = false;
                _remainingSeconds = GetWorkSeconds();
                _isRunning = false;
                _timer.Stop();
                StartPauseButton.Content = "Start";
                SetInputsEnabled(true);
                _history.Add($"{DateTime.Now:HH:mm} — cykl {_completedCycles}");
                HistoryList.ItemsSource = _history.ToArray();
            }
            else
            {
                // Work finished → auto-start break
                _completedCycles++;
                _isBreakPhase = true;
                _remainingSeconds = GetBreakSeconds();
            }
        }

        UpdateDisplay();
    }
  
    // --- Button handlers ------------------------------------------------

    private void OnStartPauseClicked(object? sender, RoutedEventArgs e)
    {
        if (_isRunning)
        {
            // Pause
            _timer.Stop();
            _isRunning = false;
            StartPauseButton.Content = "Wznów";
            SetInputsEnabled(true);
        }
        else
        {
            // Start / Resume
            if (!_isBreakPhase && !_timer.IsEnabled)
            {
                // If freshly reset or just opened, recalculate from inputs
                if (_remainingSeconds == GetWorkSeconds())
                {
                    _remainingSeconds = GetWorkSeconds();
                }
            }

            _timer.Start();
            _isRunning = true;
            StartPauseButton.Content = "Pauza";
            SetInputsEnabled(false);
        }
    }

    private void OnResetClicked(object? sender, RoutedEventArgs e)
    {
        _timer.Stop();
        _isRunning = false;
        _isBreakPhase = false;
        _completedCycles = 0;
        _remainingSeconds = GetWorkSeconds();

        StartPauseButton.Content = "Start";
        SetInputsEnabled(true);
        UpdateDisplay();
    }
}