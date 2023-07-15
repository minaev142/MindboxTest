select 
	p.Id,
	p.Name,
	c.Id as CatgoryId,
	c.Name as CategoryName
from dbo.Product p
left join dbo.ProductCategory pc on pc.ProductId = p.Id
left join dbo.Category c on c.Id = pc.CategoryId;