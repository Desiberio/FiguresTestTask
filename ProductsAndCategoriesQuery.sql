select p.Name, c.Name
from Products p
inner join Products_Categories pc on p.ProductId = pc.ProductId
left join Categories c on c.CategoryId = pc.CategoryId;