﻿using Content.Server.Power.Components;

namespace Content.Server.Power.Generation.Teg;

/// <summary>
/// Sensor data reported by the <see cref="TegGeneratorComponent"/> when queried over the device network.
/// </summary>
/// <seealso cref="TegSystem"/>
public sealed class TegSensorData
{
    /// <summary>
    /// Information for the A-side circulator.
    /// </summary>
    public Circulator CirculatorA;

    /// <summary>
    /// Information for the B-side circulator.
    /// </summary>
    public Circulator CirculatorB;

    /// <summary>
    /// The amount of energy (Joules) generated by the TEG last atmos tick.
    /// </summary>
    /// <seealso cref="TegGeneratorComponent.LastGeneration"/>
    public float LastGeneration;

    /// <summary>
    /// Ramping position for the TEG power generation.
    /// </summary>
    /// <seealso cref="TegGeneratorComponent.RampPosition"/>
    public float RampPosition;

    /// <summary>
    /// Power (Watts) actually being supplied by the TEG to connected power network.
    /// </summary>
    /// <seealso cref="PowerSupplierComponent.CurrentSupply"/>
    public float PowerOutput;

    /// <summary>
    /// Information for a single TEG circulator.
    /// </summary>
    /// <param name="InletPressure">Pressure measured at the circulator's input pipe</param>
    /// <param name="OutletPressure">Pressure measured at the circulator's output pipe</param>
    /// <param name="InletTemperature">Temperature measured at the circulator's input pipe</param>
    /// <param name="OutletTemperature">Temperature measured at the circulator's output pipe</param>
    public record struct Circulator(
        float InletPressure,
        float OutletPressure,
        float InletTemperature,
        float OutletTemperature);
}
