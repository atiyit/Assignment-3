using System.Text.Json;

namespace Models {
public class Adult : Person {
    public string jobTitle { get; set; }

    public override string ToString() {
        return JsonSerializer.Serialize(this);
    }

    public void Update(Adult toUpdate) {
        jobTitle = toUpdate.jobTitle;
        base.Update(toUpdate);
    }

}
}