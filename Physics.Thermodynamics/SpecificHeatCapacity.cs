namespace ktsu.io.Physics.Thermodynamics;

using System.Numerics;
using ktsu.io.PhysicalQuantity;
using ktsu.io.PhysicalQuantity.Generic;

/// <summary>
/// Represents a specific heat capacity quantity measured in joules per kelvin per kilogram.
/// </summary>
[SIUnit("J/kg⋅K", "joule per kelvin per kilogram", "joules per kelvin per kilogram")]
public sealed record SpecificHeatCapacity
	: PhysicalQuantity<SpecificHeatCapacity>
{
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="SpecificHeatCapacity"/>.
/// </summary>
public static class SpecificHeatCapacityConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="SpecificHeatCapacity"/> measured in joules per kelvin per kilogram.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="SpecificHeatCapacity"/> instance representing the specified value in joules per kelvin per kilogram.</returns>
	public static SpecificHeatCapacity JoulesPerKelvinPerKilogram<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, SpecificHeatCapacity>();

	/// <summary>
	/// Converts an <see cref="SpecificHeatCapacity"/> value to a numeric value measured in joules per kelvin per kilogram.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="SpecificHeatCapacity"/> value to convert.</param>
	/// <returns>The numeric value representing the specific heat capacity in joules per kelvin per kilogram.</returns>
	public static TNumber JoulesPerKelvinPerKilogram<TNumber>(this SpecificHeatCapacity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();
}
