﻿using BFQG.Entities;

namespace BFQG.Models;

public class RoomModel
{
    public int Id { get; set; }
    public Teacher Teacher { get; set; }

    public List<Student> Students { get; set; } = new List<Student>();

    public int SubjectId { get; set; }
    public int GroupId { get; set; }

    public List<LabModel> Labs { get; set; } = new List<LabModel>();

    public List<CompleteLaboratoryModel> CompleteLabs { get; set; } = new List<CompleteLaboratoryModel>();

    public TimeOnly SumTime { get; set; }

    public List<LabStudent> QueueLabs { get; set; } = new List<LabStudent>();

    public List<LabsStudent> PrepareStudent { get; set; } = new List<LabsStudent>();

    public bool LessoStart { get; set; } = false;

    public TimeOnly StartTime { get; set; }

    public TimeOnly AvgTime => new TimeOnly(SumTime.Ticks / (CompleteLabs.Count == 0 ? 1 : CompleteLabs.Count));

}
