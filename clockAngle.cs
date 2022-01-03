
// find the smallest angle between the two hands of an analog clock 
// given time
using System;

class Program
{

    static void Main(){
        Console.WriteLine("Tell me the time (in format XX:xx) : ");
        string[] time = Console.Read().Split(':');
        int hour = Convert.ToInt32(time[0]);
        int min = Convert.ToInt32(time[1]);

        Console.WriteLine(getHandAngle(hour,min));
    }

    static int getHandAngle(int hour, int min){
        
        if(min == 0) min=60;

        return hour*30 - min*6; 
    }
}