﻿namespace Objectivity.AutoFixture.XUnit2.AutoMoq.Tests.Common
{
    using System;
    using AutoMoq.Common;
    using FluentAssertions;
    using Xunit;

    [Collection("Check")]
    [Trait("Category", "Common")]
    public class CheckTests
    {
        [Fact(DisplayName = "GIVEN uninitialized object WHEN NotNull is invoked THEN exception is thrown")]
        public void GivenUninitializedObject_WhenNotNullIsInvoked_ThenExceptionIsThrown()
        {
            // Arrange
            const object value = null;

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => value.NotNull("value"));
        }

        [Fact(DisplayName = "GIVEN initialized object WHEN NotNull is invoked THEN the same object is returned")]
        public void GivenInitializedObject_WhenNotNullIsInvoked_ThenTheSameObjectIsReturned()
        {
            // Arrange
            var value = new object();

            // Act
            var result = value.NotNull("value");

            // Assert
            result.Should().Be(value);
        }
    }
}