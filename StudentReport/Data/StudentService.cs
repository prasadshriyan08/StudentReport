using Microsoft.EntityFrameworkCore;

namespace StudentReport.Data
{
    public class StudentService
    {
        private StudentsDbContext _dbContext;

        public StudentService(StudentsDbContext dbContext)
        {
            this._dbContext= dbContext;
        }

        #region Students
        public async Task<List<Students>> GetStudentsAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public async Task<Students> AddStudentsAsync(Students students)
        {
            try
            {
                _dbContext.Students.Add(students);
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
            return students;
        }

        public async Task<Students> UpdateStudentsAsync(Students students)
        {
            try
            {
                var studentExist = _dbContext.Students.FirstOrDefault(s => s.Id == students.Id);
                if (studentExist != null)
                {
                    _dbContext.Update(students);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return students;
        }

        public async Task DeleteStudentsAsync(Students students)
        {
            try
            {
                    _dbContext.Students.Remove(students);
                    await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Classes
        public async Task<List<Classes>> GetClassesAsync()
        {
            return await _dbContext.Classes.ToListAsync();
        }

        public async Task<Classes> AddClassesAsync(Classes classes)
        {
            try
            {
                _dbContext.Classes.Add(classes);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return classes;
        }

        public async Task<Classes> UpdateClassesAsync(Classes classes)
        {
            try
            {
                var classExist = _dbContext.Classes.FirstOrDefault(s => s.Id == classes.Id);
                if (classExist != null)
                {
                    _dbContext.Update(classes);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return classes;
        }

        public async Task DeleteClassesAsync(Classes classes)
        {
            try
            {
                _dbContext.Classes.Remove(classes);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Countries
        public async Task<List<Countries>> GetCountriesAsync()
        {
            return await _dbContext.Countries.ToListAsync();
        }

        public async Task<Countries> AddCountriesAsync(Countries countries)
        {
            try
            {
                _dbContext.Countries.Add(countries);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return countries;
        }

        public async Task<Countries> UpdateCountriesAsync(Countries countries)
        {
            try
            {
                var classExist = _dbContext.Countries.FirstOrDefault(s => s.Id == countries.Id);
                if (classExist != null)
                {
                    _dbContext.Update(countries);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return countries;
        }

        public async Task DeleteCountriesAsync(Countries countries)
        {
            try
            {
                _dbContext.Countries.Remove(countries);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        public async Task<List<Classes>> GetStudentCountByClass()
        {
            return await _dbContext.Classes.Include(c => c.Students).ToListAsync();
        }

        public async Task<List<Countries>> GetStudentCountByCountry()
        {
            return await _dbContext.Countries.Include(c => c.Students).ToListAsync();
        }

        //public async Task<List<Students>> GetStudentsAverageAge()
        //{
        //    return await _dbContext.Students.ToListAsync();
        //}
    }
}
