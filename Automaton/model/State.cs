using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaton.model
{
    class State
    {

        private String name;
        private List<Transition> transitions;

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to allow the instances creation for this class
        * @param {String} name The name of the state that is being created
        */
        public State(String name)
        {
            this.name = name;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the name of the state
        * @returns {String} String belong to the state's name
        */
        public String getName()
        {
            return name;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the state's name
        * <b>pre:</b> The input name needs to be != null
        * @param {String} name The name you want to assign for the actual state
        * @returns The method is void, so it does not have return
        */
        public void setName(String name)
        {
            this.name = name;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the transitions of the state
        * @returns {List<Transition>} List of transitions that belong to the state
        */
        public List<Transition> getTransitions()
        {
            return transitions;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method add one transitions to the transition list of the state
        * <b>pre:</b> The input transtion needs to be != null
        * @param {Transition} transition The transitions that is wanted to be added
        * @returns The method is void, so it does not have return
        */
        public void addTransition(Transition transition)
        {
            if (transitions == null)
            {
                transitions = new List<Transition>();
            }
            transitions.Add(transition);
        }

    }
}
