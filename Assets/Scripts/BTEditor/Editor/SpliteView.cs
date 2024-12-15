using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpliteView : TwoPaneSplitView
{
    public new class UxmlFactory : UxmlFactory<SpliteView, UxmlTraits> { }

    public SpliteView()
    {
    }
}