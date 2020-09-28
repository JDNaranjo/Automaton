using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaton.model
{
    class Transition
    {

        private State origin;
        private State destination;
        private Char input;
        private String output;

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to allow the instances creation for this class
        * @param {State} origin The starting state of the transition
        * @param {State} destination The final state of the transition
        * @param {Char} input The character which will change the state
        * @param {String} output The output of the transition
        */
        public Transition(State origin, State destination, Char input, String output)
        {
            this.origin = origin;
            this.destination = destination;
            this.input = input;
            this.output = output;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the origin state of the transition
        * @returns {State} State belong to the starting state of the transition
        */
        public State getOrigin()
        {
            return origin;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the origin state of the transition
        * <b>pre:</b> The input origin needs to be != null
        * @param {State} origin The starting state of the transition
        * @returns The method is void, so it does not have return
        */
        public void setOrigin(State origin)
        {
            this.origin = origin;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the destination state of the transition
        * @returns {State} State belong to the final state of the transition
        */
        public State getDestination()
        {
            return destination;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the destination state of the transition
        * <b>pre:</b> The input destination needs to be != null
        * @param {State} destination The final state of the transition
        * @returns The method is void, so it does not have return
        */
        public void setDestination(State destination)
        {
            this.destination = destination;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the input of the transition
        * @returns {Char} Character belong to the transition input
        */
        public Char getInput()
        {
            return input;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the input of the transition
        * <b>pre:</b> The input "input" needs to be != null
        * @param {Char} input The input of the transition
        * @returns The method is void, so it does not have return
        */
        public void setInput(Char input)
        {
            this.input = input;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is the getter method for the output of the transition
        * @returns {String} String belong to the transition output
        */
        public String getOutput()
        {
            return output;
        }

        //-----------------------------------------------------------------------------------------------------
        /*
        * This method is to set another value for the output of the transition
        * <b>pre:</b> The input "output" needs to be != null
        * @param {String} output The output of the transition
        * @returns The method is void, so it does not have return
        */
        public void setOutput(String output)
        {
            this.output = output;
        }

    }
}
