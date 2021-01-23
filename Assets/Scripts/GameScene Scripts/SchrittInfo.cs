﻿using UnityEngine;
using System.Collections;

public class SchrittInfo
{
    public SchrittTypen stepType;

    internal float passedInterval;
    public float interval = 0.5f;

    public int targetIndex;
    public int childIndex;

    public Vector3 treeNodeTargetPosition;
    public Vector3 treeNodeChildPosition;
    public GameObject treeNodeTarget;
    public GameObject treeNodeChild;

    // public Vector3 lineNodeTargetPosition;
    // public Vector3 lineNodeChildPosition;
    public  GameObject lineNodeTarget;
    // public  GameObject lineNodeChild;

    private SortierManager sortingManager;

    public SchrittInfo(int targetIndex, int childIndex, SchrittTypen stepTypes, SortierManager sortingManager)
    {   
        this.targetIndex = targetIndex;
        this.childIndex = childIndex;

        this.treeNodeTarget = sortingManager.treeNodes[targetIndex];
        this.treeNodeChild = sortingManager.treeNodes[childIndex];
        this.treeNodeTargetPosition = this.treeNodeTarget.transform.position;
        this.treeNodeChildPosition = this.treeNodeChild.transform.position;
        //btnStep.posSchrittIndikator.transform.position = treeNodeTarget.transform.position;

        // this.lineNodeTarget = sortingManager.lineNodes[targetIndex];
        // this.lineNodeChild = sortingManager.lineNodes[childIndex];
        // this.lineNodeTargetPosition = this.lineNodeTarget.transform.position;
        // this.lineNodeChildPosition = this.lineNodeChild.transform.position;

        this.stepType = stepTypes;
     
    }
 

    public override string ToString()
    {
        return string.Format("{0}: {1}<->{2} in {3}", stepType, treeNodeTarget, treeNodeChild, interval);
        //return base.ToString();
    }
}