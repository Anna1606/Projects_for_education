int distanse = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int friend = 2;

int TimeCode = 0;
int count = 0;

while(distanse > 10)
{
    if(friend == 1)
    { 
        TimeCode = distanse / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else
    {
        TimeCode = distanse / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }

    distanse = distanse - (FirstFriendSpeed + SecondFriendSpeed) * TimeCode;
    count++;
 }

 Console.WriteLine(count);