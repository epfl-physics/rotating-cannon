// ----------------------------------------------------------------------------------------------------------
// Author: Austin Peel
//
// © All rights reserved. ECOLE POLYTECHNIQUE FEDERALE DE LAUSANNE, Switzerland, Section de Physique, 2024.
// See the LICENSE.md file for more details.
// ----------------------------------------------------------------------------------------------------------
﻿using UnityEngine;

// Template class for a physics simulation that can be controlled by SimulationSlideController
public abstract class Simulation : MonoBehaviour
{
    private bool isPaused = false;
    public bool IsPaused { get => isPaused; set => isPaused = value; }

    public virtual void Pause()
    {
        IsPaused = true;
    }

    public virtual void Resume()
    {
        IsPaused = false;
    }

    public virtual void TogglePlayPause()
    {
        if (IsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
}
