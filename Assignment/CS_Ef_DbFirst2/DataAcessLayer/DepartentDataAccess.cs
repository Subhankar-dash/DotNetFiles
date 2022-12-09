﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Ef_DbFirst2.Models;
using Microsoft.EntityFrameworkCore;
namespace CS_EF_DbFirst.DataAccess
{
    internal class DepartentDataAccess
    {
        OfficeContext _context;

        public DepartentDataAccess()
        {
            _context = new OfficeContext();
        }

        public async Task<List<Department>> GetAsync()
        {
            return await _context.Departments.ToListAsync();
        }
        public async Task<Department> GetAsync(int id)
        {
            return await _context.Departments.FindAsync(id);
        }
        public async Task<Department> CreateAsync(Department dept)
        {
            var res = await _context.Departments.AddAsync(dept);
            await _context.SaveChangesAsync();
            return res.Entity;
        }

        public async Task<Department> CreateDirectAsync(Department dept)
        {
            try
            {
                var res = _context.Add<Department>(dept);
                await _context.SaveChangesAsync();
                return dept;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Department> UpdateAsync(int id, Department dept)
        {

            var rec = await _context.Departments.FindAsync(id);
            if (rec != null)
            {
                // Update Individual Property
                rec.DeptName = dept.DeptName;
                rec.Location = dept.Location;
                rec.Capacity = dept.Capacity;
                await _context.SaveChangesAsync();
                return rec; // Modified REcord
            }
            else
            {
                return null;
            }
        }


        public async Task<Department> UpdateDirectAsync(int id, Department dept)
        {
            try
            {
                // USing Id to search for the ENtity
                // the deptTOUpdate will be already holding the entity 
                var deptToUpdate = await _context.Departments.FindAsync(id);
                if (deptToUpdate != null)
                {
                    // the Update() Method will be using the same 
                    // entity to First Serach (internaly) and then
                    // Update
                    var res = _context.Update<Department>(dept);
                    await _context.SaveChangesAsync();
                    return dept;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var rec = await _context.Departments.FindAsync(id);
            if (rec != null)
            {
                _context.Departments.Remove(rec);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}