﻿using MediatR;
using WebShop.Application.DTOs;

namespace WebShop.Application.Products.Commands.AddProduct
{
	public class AddProductCommand : IRequest<ProductRepresentation>
	{
		public string? SerialNumber { get; set; }
		public string? Name { get; set; }
		public string? Price { get; set; }
		public string? Category { get; set; }
	}
}
