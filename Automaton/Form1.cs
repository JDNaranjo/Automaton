using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automaton.model;

namespace Automaton
{
    public partial class Form1 : Form
    {
        //-----------------------------------------------------------------------------------------------------

        private AutomatonMachine a;

        public Form1()
        {
            InitializeComponent();
            a = new AutomatonMachine();
            charInLabel.Visible = false;
            stateInLabel.Visible = false;
            transitionInLabel.Visible = false;
            outputTxtBox.Visible = false;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method validate when the character needs to be added and when the character doesn't have to be
        * added, it throws a message in the screen
        * <b>pre:</b> The input in alphabetTxt needs to be a character
        * @param
        * @param
        * @return The method is void, so it does not have return
        */
        private void addAlphabetBtn_Click(object sender, EventArgs e)
        {
            charInLabel.Visible = false;
            stateInLabel.Visible = false;
            transitionInLabel.Visible = false;
            Char character = Convert.ToChar(alphabetTxt.Text);
            List<Char> alphabet = a.getAlphabet();

            if (alphabet != null)
            {
                if (alphabet.Contains(character)) {
                    charInLabel.Text = "This char is already in the alphabet";
                    charInLabel.Visible = true;
                }else
                {
                    addingAlphabet(character);
                }
            } else {
                addingAlphabet(character);
            }
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add every char to the alphabet set and throws a message in the screen
        * @param {Char} character The char that will be added to the alphabet
        * @return The method is void, so it does not have return
        */
        private void addingAlphabet(Char character)
        {
            a.addAlphabet(character);
            inputSBox.Items.Add(character);
            charInLabel.Text = "The character has been added succesfully";
            charInLabel.Visible = true;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method validate when the state needs to be created and when it has to be rejected,
        * and in the second case it throws a message in the screen
        * @param
        * @param
        * @return The method is void, so it does not have return
        */
        private void addStateBtn_Click(object sender, EventArgs e)
        {
            charInLabel.Visible = false;
            stateInLabel.Visible = false;
            transitionInLabel.Visible = false;
            String name = stateTxt.Text;
            State s = new State(name);
            List<State> states = a.getStates();
            Boolean tof = false;

            if (states != null)
            {
                foreach (State state in states)
                {
                    if (state.getName().Equals(s.getName())) {
                        tof = true;
                    }
                }

                if (tof) {
                    stateInLabel.Text = "This states is already in the automaton";
                    stateInLabel.Visible = true;
                }
                else
                {
                    addingState(s);
                }
            }
            else
            {
                addingState(s);
            }
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add every state to the states set and throws a message in the screen
        * @param {State} state The state will be added to the automaton
        * @return The method is void, so it does not have return
        */
        private void addingState(State s) {

            a.addState(s);
            startingSBox.Items.Add(s.getName());
            finishSBox.Items.Add(s.getName());
            stateInLabel.Text = "The state has been added succesfully";
            stateInLabel.Visible = true;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method validate when the transition needs to be created and when it has to be rejected,
        * and in the second case it throws a message in the screen
        * <b>pre:</b> The combo boxes need to have the info already added 
        * @param
        * @param
        * @return The method is void, so it does not have return
        */
        private void addTBtn_Click(object sender, EventArgs e)
        {
            charInLabel.Visible = false;
            stateInLabel.Visible = false;
            transitionInLabel.Visible = false;
            State sStarting = new State(startingSBox.SelectedItem.ToString());
            State sFinish = new State(finishSBox.SelectedItem.ToString());
            Char input = Convert.ToChar(inputSBox.SelectedItem.ToString());
            String output = outputSTxt.Text;

            List<State> states = a.getStates();

            foreach (State state in states)
            {
                if (state.getName().Equals(startingSBox.SelectedItem.ToString()))
                {
                    sStarting = state;
                }

                if (state.getName().Equals(finishSBox.SelectedItem.ToString()))
                {
                    sFinish = state;
                }
            }

            List<Transition> transitions = sStarting.getTransitions();
            Transition tr = new Transition(sStarting, sFinish, input, output);
            Boolean tof = false;

            if (transitions != null)
            {
                foreach (Transition tran in transitions)
                {
                    if (tr.getOrigin().getName().Equals(tran.getOrigin().getName()))
                    {
                        if (tr.getDestination().getName().Equals(tran.getDestination().getName()))
                        {
                            if (tr.getInput().Equals(tran.getInput()))
                            {
                                if (tr.getOutput().Equals(tran.getOutput()))
                                {
                                    tof = true;
                                }
                            }
                        }
                    }
                }

                if (tof)
                {
                    transitionInLabel.Text = "This transition is already in the automaton";
                    transitionInLabel.Visible = true;
                }
                else
                {
                    addingTransition(sStarting, tr);
                }
            }
            else
            {
                addingTransition(sStarting, tr);
            }
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add every transition to the transitions set of the starting state and throws a message in the screen
        * @param {State} sStarting The state which will have the transition
        * @param {Transition} tr The transition which will be added
        * @return The method is void, so it does not have return
        */
        private void addingTransition(State sStarting, Transition tr)
        {
            sStarting.addTransition(tr);
            transitionInLabel.Text = "The transition has been added succesfully";
            transitionInLabel.Visible = true;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method create the minimun equivalent connected automaton
        * <b>pre:</b> The automaton needs to be created completely
        * @param
        * @param
        * @return The method is void, so it does not have return
        */
        private void createBtn_Click(object sender, EventArgs e)
        {
            outputTxtBox.Visible = true;

            a.BFS();

            String aOuput = "The alphabet accepted is: {";

            for (int i = 0; i < a.getAlphabet().Count; i++)
            {
                aOuput = aOuput + a.getAlphabet().ElementAt(i) + ", ";
            }

            aOuput = aOuput + "} \nThe states of the automaton are: {";

            for (int i = 0; i < a.getStates().Count; i++)
            {
                aOuput = aOuput + a.getStates().ElementAt(i).getName() + ", ";
            }

            aOuput = aOuput + "} \nThe transitions of the automaton are: \n";

            for (int i = 0; i < a.getStates().Count; i++)
            {
                if (a.getStates().ElementAt(i).getTransitions() != null)
                {
                    for (int j = 0; j < a.getStates().ElementAt(i).getTransitions().Count; j++)
                    {
                        State origin = a.getStates().ElementAt(i);
                        State destination = a.getStates().ElementAt(i).getTransitions().ElementAt(j).getDestination();
                        Char input = origin.getTransitions().ElementAt(j).getInput();
                        String output = origin.getTransitions().ElementAt(j).getOutput();
                        aOuput = aOuput + origin.getName() + " --> " + destination.getName() + ": (" + input + ", " + output + ") \n";
                    }
                }
            }

            outputTxtBox.Text = aOuput;

        }
    }
}
