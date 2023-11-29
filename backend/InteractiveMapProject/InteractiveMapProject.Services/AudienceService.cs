using AutoMapper;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Exceptions;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;

namespace InteractiveMapProject.Services;
public class AudienceService : IAudienceService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public AudienceService(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }

    public async Task<AudienceResponseDto> CreateAsync(AudienceRequestDto request)
    {
        Audience audience = _mapper.Map<Audience>(request);
        _uow.Audiences.Add(audience);
        await _uow.SaveChangesAsync();
        return _mapper.Map<AudienceResponseDto>(audience);
    }

    public async Task DeleteAsync(Guid id)
    {
        Audience audience = await _uow.Audiences.GetAsync(id) ?? throw new EntityNotFoundException("There is no audience with that id.");
        _uow.Audiences.Remove(audience);
        await _uow.SaveChangesAsync();
    }

    public async Task<List<AudienceResponseDto>> GetAllAsync()
    {
        List<Audience> audiences = await _uow.Audiences.GetAllAsync();
        return audiences.Select(a => _mapper.Map<AudienceResponseDto>(a)).ToList();
    }

    public async Task<AudienceResponseDto> GetAsync(Guid id)
    {
        Audience audience = await _uow.Audiences.GetAsync(id) ?? throw new EntityNotFoundException("There is no audience with that id.");
        return _mapper.Map<AudienceResponseDto>(audience);
    }

    public async Task<AudienceResponseDto> UpdateAsync(Guid id, AudienceRequestDto request)
    {
        Audience audience = await _uow.Audiences.GetAsync(id) ?? throw new EntityNotFoundException("There is no audience with that id.");
        audience = _mapper.Map(request, audience);
        _uow.Audiences.Update(audience);
        await _uow.SaveChangesAsync();
        return _mapper.Map<AudienceResponseDto>(audience);
    }
}