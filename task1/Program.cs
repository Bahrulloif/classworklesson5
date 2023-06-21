var birds = new List<int>() { 0, 4, 5, 9, 4, 9, 1 };

var birdCount = new BirdCount(birds);
birdCount.LastWeek();
System.Console.WriteLine();
birds = new List<int>() { 0, 5, 1, 7, 4, 1 };
birdCount.SetValue(birds);
birdCount.LastWeek();


System.Console.WriteLine(birds[birds.Count - 1]);
birdCount.IncrementTodaysCount(); 
System.Console.WriteLine(birdCount.HasDayWithoutBirds());
System.Console.WriteLine(birdCount.CountForFirstDays(3));
System.Console.WriteLine(birdCount.BusyDays());