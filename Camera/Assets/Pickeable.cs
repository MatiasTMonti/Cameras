public class Pickeable : Interactable
{
    public override void Interact()
    {
        base.Interact();

        gameObject.SetActive(false);
    }
}
