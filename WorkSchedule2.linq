<Query Kind="Expression">
  <Connection>
    <ID>1ca4c2aa-2d76-4fd3-81eb-94d8b91ffbc4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all skills, alphabetically, showing only the description of the skill.
from item in Skills
orderby item.Description ascending
select item.Description