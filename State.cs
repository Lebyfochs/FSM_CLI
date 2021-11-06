using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FSM_CLI
{
    //Our absract 'State' class. Other AI states will inherit from this.
    public abstract class State
    {

        //This executes the actions we want the AI to perform.
        //It is an abstract function and is made to be overridden.
        public abstract void Execute(Agent agent);
        
   
        
    }

    //Idle state.
    public class IdleState : State
    {
        public override void Execute(Agent agent)
        {

            Console.WriteLine("Idle...");
            //Waits a second. We do this to stop instant spamming.
            Thread.Sleep(1000);

            //Checks to see if crops have reached a certain level before changing states.
            if (agent.crops >= 4)
            {
                Console.WriteLine("Crops Grown!");
                agent.aState = new FarmState();
            }
            
        }
    }

    //Farming state.
    public class FarmState : State
    {

        public override void Execute(Agent agent)
        {
            //Farms existing crops.
            while (agent.crops >= 0)
            {
                Console.WriteLine("Farming...");
                Console.WriteLine("Crops: " + agent.crops);
                agent.crops-=1;
                Thread.Sleep(1000);
            }

            //Announces that crops have been farmed.
            //Moves back to Idle state when farming process is finished.
            Console.WriteLine("Crops Farmed!");
            agent.aState = new IdleState();
            
        }
    }

    
}
