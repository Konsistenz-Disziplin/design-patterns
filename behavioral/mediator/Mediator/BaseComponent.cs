namespace Mediator;

public class BaseComponent
{
    protected IMediator _mediator;

    public void SetMediator(IMediator mediator){
        this._mediator = mediator;
    }
}
