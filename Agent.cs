using System;
using System.Collections.Generic;
using System.Text;


namespace FSM_CLI
{
    public class Agent
    {
        //Creating a state instance and some crops for the AI to farm.
        public State aState;
        public int crops = 0;
      

        //Runs the execute function every update.
        //Also adds 1 to crops integer and waits a second.
        public void aUpdate()
        {
            
            aState.Execute(this);
            
        }

       
    }
}


