using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cards
{
    /// <summary>
    /// Main class for View Model
    /// TODO: follow guidelines
    /// </summary>
    public class CardsViewModel : ICardsViewModel
    {
        private readonly IDispatcher _dispatcher;
        public CardsViewModel(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public System.Collections.ObjectModel.ObservableCollection<ProbabilitySet> EvaluatedSets
        {
            get
            {
                System.Collections.ObjectModel.ObservableCollection<ProbabilitySet> evaluated = new System.Collections.ObjectModel.ObservableCollection<ProbabilitySet>();
                return evaluated;
            }
            set
            {
                EvaluatedSets.ToList<ProbabilitySet>()[0] = value[0];
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("EvaluatedSets"));
            }
        }
        private IList<CardRank> _availabeRanks;
        public IList<CardRank> AvailableRanks   // RANKS
        {
            get
            {
                List<CardRank> availableRanks = new List<CardRank>(1);
                availableRanks.Add(new CardRank());
                return availableRanks;
            }
        }
   
        public IList<CardRank> ChosenRanks
        {
            get
            {
                List<CardRank> chosen = new List<CardRank>(0);
                return chosen;
            }
            set
            {
                ChosenRanks.ToList<CardRank>()[0] = value[0];
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("ChosenRanks"));
            }
        }
        public IList<CardSuit> AvailableSuits // SUITS
        {
            get
            {
                List<CardSuit> availableSuits = new List<CardSuit>(1);
                availableSuits.Add(new CardSuit());
                return availableSuits;
            }
        }

        public IList<CardSuit> ChosenSuits
        {
            get
            {
                List<CardSuit> chosen = new List<CardSuit>(0);
                return chosen;
            }
            set
            {
                ChosenSuits.ToList<CardSuit>()[0] = value[0];
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("ChosenSuits"));
            }
        }

        private ProbabilitySet _highestProbability;
        public ProbabilitySet HighestProbability
        {
            get { return _highestProbability; }
        }
        private System.Windows.Input.ICommand _saveSearchesCommand;
        public System.Windows.Input.ICommand SaveSearchesCommand
        {
            get { return _saveSearchesCommand; }
        }
        private System.Windows.Input.ICommand _calcCommand;
        public System.Windows.Input.ICommand CalcCommand
        {
            get { return _calcCommand; }
        }
        private System.Windows.Input.ICommand _showHighestCommand;
        public System.Windows.Input.ICommand ShowHighestCommand
        {
            get { return _showHighestCommand; }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
}
