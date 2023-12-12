using System.Net.Http.Json;
using Domain.Common.DTOs;
using Microsoft.AspNetCore.Components;

namespace MegaQuiz.Client.Pages;

public partial class QuestionsView : ComponentBase
{
    private readonly HttpClient _client;

    public QuestionsView(HttpClient client)
    {
        _client = client;
    }

    public List<QuestionDto> Questions { get; set; } = new List<QuestionDto>();

    protected override async Task OnInitializedAsync()
    {
        Questions = await _client.GetFromJsonAsync<List<QuestionDto>>("/questions/");
    }
}