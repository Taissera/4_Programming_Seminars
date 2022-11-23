// Задача про друзей и собаку, когда один друг догоняет другого

int count = 0, distance = 10000, friend = 2, time = 0;
int FirstFriendSpeed = 2, SecondFriendSpeed = 1, DogSpeed = 5;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (DogSpeed - FirstFriendSpeed - SecondFriendSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (DogSpeed + FirstFriendSpeed - SecondFriendSpeed);
        friend = 1;
    }
distance = distance - (FirstFriendSpeed - SecondFriendSpeed) * time;
count++;
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз.");