<Query Kind="Statements">
  <Connection>
    <ID>1ca4c2aa-2d76-4fd3-81eb-94d8b91ffbc4</ID>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

string[] days = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}; // can create array from Mon - Fri, but then Day = days[result.Key] -1 !
var stuff =		from data in Shifts.ToList()//.AsEnumerable() //pull the data into RAM and treat as Object graph
				where data.PlacementContract.Location.Name.Contains("NAIT")
				group data by data.DayOfWeek into result
				select new
				{
					Day = days[result.Key],
					EmployeesNeeded = result.Sum(r => r.NumberOfEmployees)
				};
stuff.Dump();