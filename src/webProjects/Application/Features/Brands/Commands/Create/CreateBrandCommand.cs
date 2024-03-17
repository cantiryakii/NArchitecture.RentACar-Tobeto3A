using Application.Features.Brands.Dtos;
using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommand : IRequest<CreatedBrandResponse>
{
    public string Name { get; set; }
    public int Interval => 1;

    public bool BypassCache { get; }
    public string CacheKey => "brand-list";

}
