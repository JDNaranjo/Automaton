using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaton.model
{
    class AutomatonMachine
    {

        private List<State> states;
        private List<Char> alphabet;

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add a state to the automaton
        * <b>pre:</b> The input state needs to be != null
        * @param {State} state The state to be added
        * @return The method is void, so it does not have return
        */
        public void addState(State state)
        {
            if (states == null)
            {
                states = new List<State>();
            }
            states.Add(state);
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the states list
        * @returns {List<State>} List of all the states that the automaton have
        */
        public List<State> getStates()
        {
            return states;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the alphabet list
        * @returns {List<Char>} List of all the alphabet characters that the automaton have
        */
        public List<Char> getAlphabet()
        {
            return alphabet;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add a character to the alphabet that belongs to the automaton
        * <b>pre:</b> The input alphabetChar needs to be a character and != null
        * @param {Char} alphabetChar The character which will be added to the alphabet
        * @return The method is void, so it does not have return
        */
        public void addAlphabet(Char alphabetChar)
        {
            if (alphabet == null)
            {
                alphabet = new List<Char>();
            }
            alphabet.Add(alphabetChar);
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method go through the automaton and delete the states that are not connected to the initial one
        * @return The method is void, so it does not have return
        */
        public void BFS() {

            int s = 0;
            bool[] visited = new bool[states.Count()];
            for (int i = 0; i < states.Count(); i++)
                visited[i] = false;

            LinkedList<int> queue = new LinkedList<int>();

            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {
                s = queue.First();
                queue.RemoveFirst();
 
                List<Transition> list = states.ElementAt(s).getTransitions();

                if (list != null) {
                    foreach (var val in list)
                    {
                        if (!visited[states.IndexOf(val.getDestination())])
                        {
                            visited[states.IndexOf(val.getDestination())] = true;
                            queue.AddLast(states.IndexOf(val.getDestination()));
                        }
                    }
                }
            }

            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i])
                {
                    Console.WriteLine(states.ElementAt(i).getName());
                    states.RemoveAt(i);
                    Console.WriteLine("Succesfully deleted");
                }
            }

        }

    }
}
