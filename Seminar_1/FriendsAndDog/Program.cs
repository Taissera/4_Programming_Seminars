// Задача про друзей и собаку, когда друзья идут навстречу друг другу
int count = 0, distance = 10000, friend = 2, time = 0;
int FirstFriendSpeed = 1, SecondFriendSpeed = 2, DogSpeed = 5;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
count++;
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз.");