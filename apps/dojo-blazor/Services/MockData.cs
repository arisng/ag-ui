using DojoBlazor.Models;

namespace DojoBlazor.Services;

public static class MockData
{
    public static List<Integration> Integrations { get; } = new()
    {
        new() {
            Id = "agent-spec-langgraph",
            Name = "Open Agent Spec (LangGraph)",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "tool_based_generative_ui" }
        },
        new() {
            Id = "agent-spec-wayflow",
            Name = "Open Agent Spec (Wayflow)",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "tool_based_generative_ui" }
        },
        new() {
            Id = "langgraph",
            Name = "LangGraph (Python)",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "agentic_generative_ui", "predictive_state_updates", "shared_state", "tool_based_generative_ui", "subgraphs" }
        },
        new() {
            Id = "langgraph-fastapi",
            Name = "LangGraph (FastAPI)",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "agentic_chat_reasoning", "agentic_generative_ui", "predictive_state_updates", "shared_state", "tool_based_generative_ui", "subgraphs" }
        },
        new() {
            Id = "langgraph-typescript",
            Name = "LangGraph (Typescript)",
            Features = new() { "agentic_chat", "human_in_the_loop", "agentic_generative_ui", "predictive_state_updates", "shared_state", "tool_based_generative_ui", "subgraphs" }
        },
        new() {
            Id = "mastra",
            Name = "Mastra",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "tool_based_generative_ui" }
        },
        new() {
            Id = "mastra-agent-local",
            Name = "Mastra Agent (Local)",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "shared_state", "tool_based_generative_ui" }
        },
        new() {
            Id = "spring-ai",
            Name = "Spring AI",
            Features = new() { "agentic_chat", "shared_state", "tool_based_generative_ui", "human_in_the_loop", "agentic_generative_ui" }
        },
        new() {
            Id = "pydantic-ai",
            Name = "Pydantic AI",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "agentic_generative_ui", "shared_state", "tool_based_generative_ui" }
        },
        new() {
            Id = "adk-middleware",
            Name = "Google ADK",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "shared_state", "tool_based_generative_ui" }
        },
        new() {
            Id = "microsoft-agent-framework-dotnet",
            Name = "Microsoft Agent Framework (.NET)",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "agentic_generative_ui", "predictive_state_updates", "shared_state", "tool_based_generative_ui" }
        },
        new() {
            Id = "microsoft-agent-framework-python",
            Name = "Microsoft Agent Framework (Python)",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "agentic_generative_ui", "predictive_state_updates", "shared_state", "tool_based_generative_ui" }
        },
        new() {
            Id = "agno",
            Name = "Agno",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "tool_based_generative_ui" }
        },
        new() {
            Id = "llama-index",
            Name = "LlamaIndex",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "agentic_generative_ui", "shared_state" }
        },
        new() {
            Id = "crewai",
            Name = "CrewAI",
            Features = new() { "agentic_chat", "human_in_the_loop", "agentic_generative_ui", "predictive_state_updates", "shared_state", "tool_based_generative_ui" }
        },
        new() {
            Id = "a2a-basic",
            Name = "A2A (Direct)",
            Features = new() { "vnext_chat" }
        },
        new() {
            Id = "middleware-starter",
            Name = "Middleware Starter",
            Features = new() { "agentic_chat" }
        },
        new() {
            Id = "server-starter",
            Name = "Server Starter",
            Features = new() { "agentic_chat" }
        },
        new() {
            Id = "server-starter-all-features",
            Name = "Server Starter (All Features)",
            Features = new() { "agentic_chat", "backend_tool_rendering", "human_in_the_loop", "agentic_generative_ui", "predictive_state_updates", "shared_state", "tool_based_generative_ui" }
        },
        new() {
            Id = "a2a",
            Name = "A2A",
            Features = new() { "a2a_chat" }
        },
        new() {
            Id = "aws-strands",
            Name = "AWS Strands",
            Features = new() { "agentic_chat", "backend_tool_rendering", "agentic_generative_ui", "shared_state", "human_in_the_loop" }
        },
    };

    public static List<FeatureConfig> Features { get; } = new()
    {
        new() { Id = "agentic_chat", Name = "Agentic Chat", Description = "Chat with your Copilot and call frontend tools", Tags = new() { "Chat", "Tools", "Streaming" } },
        new() { Id = "backend_tool_rendering", Name = "Backend Tool Rendering", Description = "Render and stream your backend tools to the frontend.", Tags = new() { "Agent State", "Collaborating" } },
        new() { Id = "human_in_the_loop", Name = "Human in the loop", Description = "Plan a task together and direct the Copilot to take the right steps", Tags = new() { "HITL", "Interactivity" } },
        new() { Id = "agentic_generative_ui", Name = "Agentic Generative UI", Description = "Assign a long running task to your Copilot and see how it performs!", Tags = new() { "Generative ui (agent)", "Long running task" } },
        new() { Id = "tool_based_generative_ui", Name = "Tool Based Generative UI", Description = "Haiku generator that uses tool based generative UI.", Tags = new() { "Generative ui (action)", "Tools" } },
        new() { Id = "shared_state", Name = "Shared State between agent and UI", Description = "A recipe Copilot which reads and updates collaboratively", Tags = new() { "Agent State", "Collaborating" } },
        new() { Id = "predictive_state_updates", Name = "Predictive State Updates", Description = "Use collaboration to edit a document in real time with your Copilot", Tags = new() { "State", "Streaming", "Tools" } },
        new() { Id = "agentic_chat_reasoning", Name = "Agentic Chat Reasoning", Description = "Chat with a reasoning Copilot and call frontend tools", Tags = new() { "Chat", "Tools", "Streaming", "Reasoning" } },
        new() { Id = "subgraphs", Name = "Subgraphs", Description = "Have your tasks performed by multiple agents, working together", Tags = new() { "Chat", "Multi-agent architecture", "Streaming", "Subgraphs" } },
        new() { Id = "a2a_chat", Name = "A2A Chat", Description = "Chat with your Copilot and call frontend tools", Tags = new() { "Chat", "Tools", "Streaming" } },
        new() { Id = "vnext_chat", Name = "VNext Chat", Description = "Chat based on CopilotKit vnext", Tags = new() { "Chat", "VNext", "Streaming" } },
    };
}
