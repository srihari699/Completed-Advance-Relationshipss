using Dotnet_Demo.Dtos.Skill;
using Dotnet_Demo.Dtos.Weapon;
using Dotnet_Demo.Models;

namespace Dotnet_Demo
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon,GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}
