# Slacky Notes

Slacky Notes is a planned Windows and macOS desktop app that turns clear task assignments in Slack direct messages into small, always-on-top sticky notes.

It favors precision over recall: if a message is ambiguous, it should not create a task.

> **Status:** Architecture and product plan. The application has not been implemented yet.

## What it will do

- Watch Slack direct messages and group direct messages for clear assignments to the connected user.
- Create a concise sticky note with a link back to the source Slack message.
- Let users edit, complete, dismiss, or delete notes locally.
- Keep one active desktop device connected to each Slack identity.

## How it works

1. The desktop app connects to Slack through OAuth in the system browser.
2. Slack sends a direct-message event to a Cloudflare Worker.
3. The Worker verifies and deduplicates the event, then asks OpenAI to classify the message using constrained structured output.
4. High-confidence tasks are placed in an encrypted temporary outbox.
5. The active desktop app polls for tasks, saves each one locally, displays it as a note, and acknowledges delivery.

## Planned stack

| Component | Technology |
| --- | --- |
| macOS app | Swift and SwiftUI |
| Windows app | C# with WinUI 3 and .NET |
| Backend | TypeScript on Cloudflare Workers |
| Database | Cloudflare D1 |
| Task extraction | OpenAI structured output |

## Privacy principles

- Slack OAuth tokens and temporary task records are encrypted at rest.
- Raw Slack message bodies, prompts, and conversation transcripts are not stored in the server database.
- Notes and their history remain local to the desktop app.
- Users can disconnect Slack and delete local data.

## Scope

The first release is intentionally small: Slack DMs and group DMs only, no inferred deadlines or priorities, no multi-device sync, no billing, and no channel scanning.

## Architecture

The detailed V1 architecture, delivery guarantees, security boundaries, phases, and test plan are in [docs/slacky-notes-architecture.md](docs/slacky-notes-architecture.md). A rendered PDF is also available in [docs/slacky-notes-architecture.pdf](docs/slacky-notes-architecture.pdf).

## License

No license has been selected yet.
