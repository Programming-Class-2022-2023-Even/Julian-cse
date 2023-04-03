using System;

namespace CarExample
{
    //Car object
    class Car
    {
        //Private variables for the x and the y 
        private int xPos;
        private int yPos;

        //Empty constructor 
        public Car()
        {
            this.xPos = 0;
            this.yPos = 0;
        }

        //Parameterized constructor
        public Car(int x, int y)
        {
            this.xPos = x;
            this.yPos = y;
        }

        /// <summary>
        /// TO move the car forward
        /// </summary>
        /// <param name="distance">distance to move the forward</param>
        public void Forward(int distance)
        {
            yPos += distance;
        }

        /// <summary>
        /// To move the card reverse
        /// </summary>
        /// <param name="distance">distance to move the reverse</param>
        public void Reverse(int distance)
        {
            Forward(-distance);
        }

        /// <summary>
        /// To turn the car in right direction 
        /// </summary>
        public void TurnRight()
        {
            //It will change the x and the y co ordinates as the direction changes . 
            int temp = xPos;

            //x become y 
            xPos = yPos;

            //y becomes negative 
            yPos = -temp;
        }

        /// <summary>
        /// to turn the car in left direction
        /// </summary>
        public void TurnLeft()
        {
            // I will change the x and the y co ordinates 
            int temp = xPos;

            //x become negative y 
            xPos = -yPos;

            //y becomes x.
            yPos = temp;
        }

        //Method to display the posisiton of the car
        public void DisplayPosition()
        {
            Console.WriteLine("Current position of car : ({0}, {1})", xPos, yPos);
        }
    }

    //Main class to test the class Car
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create the sample car object
            Car sampleCar = new();

            //position should be ( 0 ,0 ) as just started
            sampleCar.DisplayPosition();
            sampleCar.Forward(5);
            sampleCar.TurnRight();

            //Position should be ( 5, 0 ) as car is turned right
            sampleCar.DisplayPosition();
            sampleCar.Forward(3);
            sampleCar.Reverse(2);

            //position should be ( 5 , 1 ) 
            sampleCar.DisplayPosition();
            sampleCar.TurnLeft();
            sampleCar.Forward(1);

            //Position should be ( -1 , 6 ) 
            sampleCar.DisplayPosition();
        }
    }
}