﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Models;

public class Engines
{
    [Key]
    [DisplayName("Id")]
    public int EngineId { get; set; }
    
    [DisplayName("Engine Name")]
    public string Name { get; set; }
    
    [DisplayName("Release Date")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime ReleaseDate { get; set; }

    public string Developer { get; set; }

    [DisplayName("Type License")]
    public string License { get; set; }

    [DisplayName("Engine Description")]
    public string EngineDescription { get; set; }

    [DisplayName("Engine Logo")]
    public string EngineLogo { get; set; }
    
    public List<Games> GamesList { get; set; } = new List<Games>();

}