import { test, expect } from '@playwright/test';

test('UX/UI smoke test', async ({ page }) => {
  page.on('console', msg => console.log('PAGE LOG:', msg.text()));
  page.on('pageerror', err => console.log('PAGE ERROR:', err.message));

  // 1. Visit the home page
  // The baseURL is configured in playwright.config.ts as http://localhost:5062
  await page.goto('/');

  // 2. Verify Sidebar is visible by checking for the specific header text
  // MainLayout has a mobile header (h1.text-sm) and Sidebar has a desktop header (h1.text-lg).
  // We target the desktop one which should be visible in standard viewport.
  const sidebarHeader = page.locator('h1.text-lg').getByText('AG-UI Interactive Dojo');
  await expect(sidebarHeader).toBeVisible();

  // 3. Verify "Select an integration" text is present (which appears on the home page when no integration is selected)
  await expect(page.getByRole('heading', { name: 'Select an Integration' })).toBeVisible();

  // 4. Interact with Integration Picker (select "Mastra")
  // The sidebar has a header "Integrations" and a select box below it.
  const integrationSelect = page.getByRole('combobox');
  await integrationSelect.selectOption({ label: 'Mastra' }); // Matching the Name in MockData

  // 5. Check if URL changes to /mastra
  await expect(page).toHaveURL(/\/mastra$/);

  // 6. Verify Demo List populates.
  // We expect "Agentic Chat" to be present in the sidebar list.
  const demoItem = page.getByText('Agentic Chat').first();
  await expect(demoItem).toBeVisible();

  // 7. Click a demo (e.g., "Agentic Chat")
  await demoItem.click();

  // 8. Verify URL changes to /mastra/feature/agentic_chat
  await expect(page).toHaveURL(/\/mastra\/feature\/agentic_chat/);

  // 9. Verify "Preview" tab is active.
  // In FeaturePage.razor, the "Preview" tab is the default.
  // We can check if the "Preview" button has the active class (bg-background text-foreground shadow-sm).
  // Or simply check that the "PREVIEW: agentic_chat" text is visible (based on my analysis of FeaturePage.razor).
  await expect(page.getByText('PREVIEW: agentic_chat')).toBeVisible();

  // 10. Click "Code" tab.
  const codeTab = page.getByRole('button', { name: 'Code' });
  await codeTab.click();

  // 11. Verify URL query param ?view=code
  await expect(page).toHaveURL(/.*view=code/);

  // 12. Verify Code Viewer is visible
  await expect(page.getByText('Code Viewer')).toBeVisible();
  
  // Optionally check for some text that indicates code view
  await expect(page.getByText('Source code for agentic_chat would be displayed here')).toBeVisible();
});
