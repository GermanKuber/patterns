﻿using Implementations.ChainOfResponsibility.Decorator;

namespace Entities.Interfaces
{
    public interface IDecorator<TUpdating, TParameters> : IStrategy<TUpdating, TParameters> where TParameters : IParameters
    {
        void Execute(TUpdating updatingEntity, TParameters parameter);
        void SetStrategy(IStrategy<TUpdating, TParameters> strategyToDecorate);
        void SetStepsToProcess(IDecoratorStepAuctionChainOfResponsibility<TUpdating, TParameters> firstStep);
    }

}