using System;

//Basic CLI example of a Finite State Machine.

namespace FSM_CLI
{
    class Program
    {
     

        static void Main(string[] args)
        {
            
            Console.WriteLine("--- RUNNING DEMO ---");

            //new AI instance and set base class.
            Agent agent1 = new Agent();
            agent1.aState = new IdleState();


            //Main loop. Agent updates itself.
            while(true)
            {
                agent1.crops++;
                agent1.aUpdate();
                

            }

            
        }
    }
}
