﻿using Lw.FchStore.Domain.Entities;

namespace Lw.FchStore.Domain.Interfaces.Services;

public interface ICategoryAppServices : IAppServices<Category>
{
    Task<List<CategoryTree>> GetTree();

}