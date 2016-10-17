<Query Kind="Statements">
  <Connection>
    <ID>f63d7f1b-c0cd-4efb-a857-b4d18946fd7f</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//from contract in PlacementContracts
//where contract.Location.Name.Contains("NAIT")
//select new
//{
//	
//}


// Bills.Max(   x => x.BillDate   )

from contract in PlacementContracts
where contract.Location.Name.Contains("NAIT")
//group contract by contract.PlacementContractID into tempData
//orderby contract.PlacementContractID into tempData
select new
{
	newShift = from shift in Shifts
			   select new
				{
					DayOfWeek = shift.DayOfWeek,
					EmployeesNeeded = shift.NumberOfEmployees.Sum( x => x.NumberOfEmployees)
				}
//	tempdata.Key = Shifts.DayOfWeek,
//	EmployeesNeeded = Shifts.NumberOfEmployees.Sum( x => x.NumberOfEmployees)
};
select newShift





var answer =
from contract in PlacementContracts
group contract by contract.PlacementContractID into tempData
where tempData.contract.Location.Name.Contains("NAIT")
orderby contract.PlacementContractID
select new
{
	newShift = from shift in Shifts
			   select new
				{
					DayOfWeek = shift.DayOfWeek,
					EmployeesNeeded = shift.NumberOfEmployees.Sum( x => x.NumberOfEmployees)
				}
//	tempdata.Key = Shifts.DayOfWeek,
//	EmployeesNeeded = Shifts.NumberOfEmployees.Sum( x => x.NumberOfEmployees)
};
select newShift;